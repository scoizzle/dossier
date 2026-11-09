# Fact 80cea89b

Store id: f1e4166c-6e54-4267-bcb9-9f0bf9f324ed

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T22:39:41.6526330+00:00`

## Data

```json
{
  "end_line": 1464,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1463,
  "symbol": "Ref.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1463,"selector":"L1463-L1464","symbol":"Ref.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1464,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1463,
    "symbol": "Ref.set_source_expressions"
  },
  "id": "f1e4166c-6e54-4267-bcb9-9f0bf9f324ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6526330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1463,
        "selector": "L1463-L1464",
        "symbol": "Ref.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c1195aa8-00c1-4a6c-bbe0-0cf3f43ba3fb",
  "subject_name": "django/db/models/expressions::Ref.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
