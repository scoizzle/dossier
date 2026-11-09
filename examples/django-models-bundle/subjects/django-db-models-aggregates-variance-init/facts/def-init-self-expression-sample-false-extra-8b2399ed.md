# Fact 8b2399ed

Store id: 7c517140-82b5-4cee-8c1d-e4872d306674

## Text

```text
def __init__(self, expression, sample=False, **extra)
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
- posted_at: `2026-11-09T23:31:53.5495470+00:00`

## Data

```json
{
  "end_line": 465,
  "entity_kind": "method",
  "parent": "Variance",
  "start_line": 463,
  "symbol": "Variance.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":463,"selector":"L463-L465","symbol":"Variance.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Variance.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 465,
    "entity_kind": "method",
    "parent": "Variance",
    "start_line": 463,
    "symbol": "Variance.__init__"
  },
  "id": "7c517140-82b5-4cee-8c1d-e4872d306674",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5495470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 463,
        "selector": "L463-L465",
        "symbol": "Variance.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "2a8ef4e9-71c8-423f-9e38-3b0dd470b171",
  "subject_name": "django/db/models/aggregates::Variance.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, sample=False, **extra)"
}
```
