# Fact 361d09de

Store id: ece39231-b32a-4977-9057-81d5b636f17f

## Text

```text
def _resolve_output_field(self)
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
- posted_at: `2026-11-09T23:31:55.9705920+00:00`

## Data

```json
{
  "end_line": 1842,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1841,
  "symbol": "Subquery._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1841,"selector":"L1841-L1842","symbol":"Subquery._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1842,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1841,
    "symbol": "Subquery._resolve_output_field"
  },
  "id": "ece39231-b32a-4977-9057-81d5b636f17f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9705920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1841,
        "selector": "L1841-L1842",
        "symbol": "Subquery._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "20451c3b-653b-4be0-8f6c-08f8d37454fc",
  "subject_name": "django/db/models/expressions::Subquery._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
