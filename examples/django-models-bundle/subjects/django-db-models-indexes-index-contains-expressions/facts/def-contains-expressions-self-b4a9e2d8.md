# Fact b4a9e2d8

Store id: 0b35d77b-5687-44ee-a3e3-6ae6bccfd289

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
- posted_at: `2026-11-09T22:39:47.7687110+00:00`

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
  "id": "0b35d77b-5687-44ee-a3e3-6ae6bccfd289",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.7687110+00:00"
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
  "subject_id": "ae5c7b38-f300-45cf-b443-0eb6bad3e7f3",
  "subject_name": "django/db/models/indexes::Index.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
