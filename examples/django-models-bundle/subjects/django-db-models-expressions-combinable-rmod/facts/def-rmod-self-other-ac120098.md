# Fact ac120098

Store id: 7a35c6b8-aa94-4421-bff5-1e3e9ef3c21a

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
- posted_at: `2026-11-09T23:44:49.2562840+00:00`

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
  "id": "7a35c6b8-aa94-4421-bff5-1e3e9ef3c21a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2562840+00:00"
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
  "subject_id": "7e582994-55d3-48ad-bc4c-155a4a80a6db",
  "subject_name": "django/db/models/expressions::Combinable.__rmod__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rmod__(self, other)"
}
```
