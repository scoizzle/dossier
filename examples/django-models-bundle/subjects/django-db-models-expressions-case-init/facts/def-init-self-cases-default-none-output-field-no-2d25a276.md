# Fact 2d25a276

Store id: 81f88b5b-496b-4ea5-beaf-4f53a25b0470

## Text

```text
def __init__(self, *cases, default=None, output_field=None, **extra)
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
- posted_at: `2026-11-09T23:31:55.9578980+00:00`

## Data

```json
{
  "end_line": 1739,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1733,
  "symbol": "Case.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1733,"selector":"L1733-L1739","symbol":"Case.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1739,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1733,
    "symbol": "Case.__init__"
  },
  "id": "81f88b5b-496b-4ea5-beaf-4f53a25b0470",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9578980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1733,
        "selector": "L1733-L1739",
        "symbol": "Case.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "755e5687-1fc3-462a-9a39-345dba7b8839",
  "subject_name": "django/db/models/expressions::Case.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *cases, default=None, output_field=None, **extra)"
}
```
