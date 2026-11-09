# Fact 3a1bd054

Store id: ad9efa42-86e6-49dd-9338-4cc440176316

## Text

```text
def preprocess_lhs(self, compiler, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.9658960+00:00`

## Data

```json
{
  "end_line": 514,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 504,
  "symbol": "KeyTransform.preprocess_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":504,"selector":"L504-L514","symbol":"KeyTransform.preprocess_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.preprocess_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 514,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 504,
    "symbol": "KeyTransform.preprocess_lhs"
  },
  "id": "ad9efa42-86e6-49dd-9338-4cc440176316",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9658960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 504,
        "selector": "L504-L514",
        "symbol": "KeyTransform.preprocess_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "30a13723-da21-498b-bd00-daea4bf784d9",
  "subject_name": "django/db/models/fields/json::KeyTransform.preprocess_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def preprocess_lhs(self, compiler, connection)"
}
```
