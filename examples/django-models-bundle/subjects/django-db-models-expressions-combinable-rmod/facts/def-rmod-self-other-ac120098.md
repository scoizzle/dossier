# Fact ac120098

Store id: 2a31ecdf-261b-4df0-b997-d57d1f701622

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
- posted_at: `2026-11-09T23:31:55.7491370+00:00`

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
  "id": "2a31ecdf-261b-4df0-b997-d57d1f701622",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7491370+00:00"
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
  "subject_id": "b7d0d2e7-c885-47dc-a0b0-b9b1b3721544",
  "subject_name": "django/db/models/expressions::Combinable.__rmod__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rmod__(self, other)"
}
```
