# Fact 80cea89b

Store id: 8804550b-e46c-44a6-afa7-d8307c280d92

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
- posted_at: `2026-11-09T23:44:49.5770090+00:00`

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
  "id": "8804550b-e46c-44a6-afa7-d8307c280d92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5770090+00:00"
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
  "subject_id": "1a88f5d3-adb7-4fa8-9fc2-5094fc1c7037",
  "subject_name": "django/db/models/expressions::Ref.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
