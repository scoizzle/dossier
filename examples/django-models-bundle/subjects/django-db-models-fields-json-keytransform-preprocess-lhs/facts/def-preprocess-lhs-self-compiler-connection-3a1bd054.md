# Fact 3a1bd054

Store id: 1684dbca-fe89-48a6-87ba-7b3a18a87530

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
- posted_at: `2026-11-09T22:39:43.7067980+00:00`

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
  "id": "1684dbca-fe89-48a6-87ba-7b3a18a87530",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7067980+00:00"
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
  "subject_id": "a48d526a-3e77-4b19-84a5-3afb20901de4",
  "subject_name": "django/db/models/fields/json::KeyTransform.preprocess_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def preprocess_lhs(self, compiler, connection)"
}
```
