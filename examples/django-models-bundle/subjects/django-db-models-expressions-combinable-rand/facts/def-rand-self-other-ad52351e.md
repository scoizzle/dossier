# Fact ad52351e

Store id: eabb60c6-d1f3-4dd5-9c4f-fc415a1ba27e

## Text

```text
def __rand__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4918640+00:00`

## Data

```json
{
  "end_line": 154,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 151,
  "symbol": "Combinable.__rand__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L154","symbol":"Combinable.__rand__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rand__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 154,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 151,
    "symbol": "Combinable.__rand__"
  },
  "id": "eabb60c6-d1f3-4dd5-9c4f-fc415a1ba27e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4918640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L154",
        "symbol": "Combinable.__rand__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "82a3583b-74aa-49df-a1ca-eae25bee9a81",
  "subject_name": "django/db/models/expressions::Combinable.__rand__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rand__(self, other)"
}
```
