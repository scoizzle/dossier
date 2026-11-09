# Fact 6c839e6e

Store id: abd46e1a-9eb4-41dd-9ae0-223777b52d2a

## Text

```text
def __add__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7261970+00:00`

## Data

```json
{
  "end_line": 80,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 79,
  "symbol": "Combinable.__add__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":79,"selector":"L79-L80","symbol":"Combinable.__add__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__add__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 80,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 79,
    "symbol": "Combinable.__add__"
  },
  "id": "abd46e1a-9eb4-41dd-9ae0-223777b52d2a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7261970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 79,
        "selector": "L79-L80",
        "symbol": "Combinable.__add__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "da9723b2-3b72-447d-9c68-b30970f603c7",
  "subject_name": "django/db/models/expressions::Combinable.__add__",
  "tags": [
    "entity:method"
  ],
  "text": "def __add__(self, other)"
}
```
