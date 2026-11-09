# Fact 188b4ca9

Store id: 0d27d63d-208e-4f0b-9cd2-cd9e1404ced7

## Text

```text
def _output_field_or_none(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.6838960+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 298,
  "symbol": "WhereNode._output_field_or_none"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":298,"selector":"L298-L300","symbol":"WhereNode._output_field_or_none"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._output_field_or_none](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 298,
    "symbol": "WhereNode._output_field_or_none"
  },
  "id": "0d27d63d-208e-4f0b-9cd2-cd9e1404ced7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6838960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 298,
        "selector": "L298-L300",
        "symbol": "WhereNode._output_field_or_none"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "de2cb62b-f892-414d-8d0e-a2a6b1c8ec44",
  "subject_name": "django/db/models/sql/where::WhereNode._output_field_or_none",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _output_field_or_none(self)"
}
```
