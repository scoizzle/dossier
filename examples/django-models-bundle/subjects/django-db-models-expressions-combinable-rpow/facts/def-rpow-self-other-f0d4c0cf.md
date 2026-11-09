# Fact f0d4c0cf

Store id: 69cbc482-d4b6-4136-b434-1117c4269c33

## Text

```text
def __rpow__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4905030+00:00`

## Data

```json
{
  "end_line": 149,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 148,
  "symbol": "Combinable.__rpow__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L149","symbol":"Combinable.__rpow__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rpow__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 149,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 148,
    "symbol": "Combinable.__rpow__"
  },
  "id": "69cbc482-d4b6-4136-b434-1117c4269c33",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4905030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L149",
        "symbol": "Combinable.__rpow__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2015d1f1-eae9-4c7c-aaa1-9c675855154b",
  "subject_name": "django/db/models/expressions::Combinable.__rpow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rpow__(self, other)"
}
```
