# Fact 89572908

Store id: 59453f84-13ce-4618-b996-f818879330ed

## Text

```text
def bitor(self, other)
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
- posted_at: `2026-11-09T22:39:41.4823800+00:00`

## Data

```json
{
  "end_line": 131,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 130,
  "symbol": "Combinable.bitor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":130,"selector":"L130-L131","symbol":"Combinable.bitor"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 131,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 130,
    "symbol": "Combinable.bitor"
  },
  "id": "59453f84-13ce-4618-b996-f818879330ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4823800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 130,
        "selector": "L130-L131",
        "symbol": "Combinable.bitor"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e7bffa97-3469-43d7-b7bf-a889ccc5fb86",
  "subject_name": "django/db/models/expressions::Combinable.bitor",
  "tags": [
    "entity:method"
  ],
  "text": "def bitor(self, other)"
}
```
