# Fact 6c839e6e

Store id: f9527ba6-dde9-4449-a832-b7da2b306dd4

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
- posted_at: `2026-11-09T22:39:41.4725990+00:00`

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
  "id": "f9527ba6-dde9-4449-a832-b7da2b306dd4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4725990+00:00"
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
  "subject_id": "1a7b6961-7498-4e0b-b657-c2fc5c917e81",
  "subject_name": "django/db/models/expressions::Combinable.__add__",
  "tags": [
    "entity:method"
  ],
  "text": "def __add__(self, other)"
}
```
