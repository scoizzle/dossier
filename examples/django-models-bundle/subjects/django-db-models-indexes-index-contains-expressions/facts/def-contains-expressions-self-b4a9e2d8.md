# Fact b4a9e2d8

Store id: 2c699b2d-cf7e-4de1-9d44-6017ad30afea

## Text

```text
def contains_expressions(self)
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
- posted_at: `2026-11-09T23:32:02.9027290+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 82,
  "symbol": "Index.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L84","symbol":"Index.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 82,
    "symbol": "Index.contains_expressions"
  },
  "id": "2c699b2d-cf7e-4de1-9d44-6017ad30afea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9027290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L84",
        "symbol": "Index.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "b6215f4a-023d-4963-b861-9b6e3e6e567d",
  "subject_name": "django/db/models/indexes::Index.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
