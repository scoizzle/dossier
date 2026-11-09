# Fact ac120098

Store id: e0f55e48-3e8f-46c8-b0b3-58460f4544b1

## Text

```text
def __rmod__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4893600+00:00`

## Data

```json
{
  "end_line": 146,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 145,
  "symbol": "Combinable.__rmod__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":145,"selector":"L145-L146","symbol":"Combinable.__rmod__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rmod__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 146,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 145,
    "symbol": "Combinable.__rmod__"
  },
  "id": "e0f55e48-3e8f-46c8-b0b3-58460f4544b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4893600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 145,
        "selector": "L145-L146",
        "symbol": "Combinable.__rmod__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0365ed65-29e8-489d-8714-7e368c48ec05",
  "subject_name": "django/db/models/expressions::Combinable.__rmod__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rmod__(self, other)"
}
```
