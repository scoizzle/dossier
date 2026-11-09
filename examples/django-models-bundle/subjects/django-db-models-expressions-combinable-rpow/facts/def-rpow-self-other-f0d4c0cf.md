# Fact f0d4c0cf

Store id: 47525fd2-5a15-4622-bfea-08dc89b0433b

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
- posted_at: `2026-11-09T23:31:55.7503980+00:00`

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
  "id": "47525fd2-5a15-4622-bfea-08dc89b0433b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7503980+00:00"
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
  "subject_id": "8ac59a7a-5d10-49dc-8348-700db05fac9a",
  "subject_name": "django/db/models/expressions::Combinable.__rpow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rpow__(self, other)"
}
```
