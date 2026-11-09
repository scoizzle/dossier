# Fact 4f7224b3

Store id: b8c6abed-d95b-4dbd-bbd3-0e4638cc98dc

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:58.0010030+00:00`

## Data

```json
{
  "end_line": 649,
  "entity_kind": "method",
  "parent": "KeyTransformExact",
  "start_line": 627,
  "symbol": "KeyTransformExact.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":627,"selector":"L627-L649","symbol":"KeyTransformExact.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformExact.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 649,
    "entity_kind": "method",
    "parent": "KeyTransformExact",
    "start_line": 627,
    "symbol": "KeyTransformExact.process_rhs"
  },
  "id": "b8c6abed-d95b-4dbd-bbd3-0e4638cc98dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0010030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 627,
        "selector": "L627-L649",
        "symbol": "KeyTransformExact.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "3c1d4a50-6c1c-4b73-b35c-a40d406f9c08",
  "subject_name": "django/db/models/fields/json::KeyTransformExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
