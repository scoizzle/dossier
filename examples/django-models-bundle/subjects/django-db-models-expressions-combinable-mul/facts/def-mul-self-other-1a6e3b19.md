# Fact 1a6e3b19

Store id: f6ee7d60-ba22-414c-867b-de3fa5b5757b

## Text

```text
def __mul__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2429350+00:00`

## Data

```json
{
  "end_line": 86,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 85,
  "symbol": "Combinable.__mul__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":85,"selector":"L85-L86","symbol":"Combinable.__mul__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__mul__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 86,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 85,
    "symbol": "Combinable.__mul__"
  },
  "id": "f6ee7d60-ba22-414c-867b-de3fa5b5757b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2429350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 85,
        "selector": "L85-L86",
        "symbol": "Combinable.__mul__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "41ba14fa-8868-4abd-9636-895236baab24",
  "subject_name": "django/db/models/expressions::Combinable.__mul__",
  "tags": [
    "entity:method"
  ],
  "text": "def __mul__(self, other)"
}
```
