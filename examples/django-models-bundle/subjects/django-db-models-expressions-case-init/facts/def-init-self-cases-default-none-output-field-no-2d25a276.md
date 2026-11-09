# Fact 2d25a276

Store id: a0ed6756-60e3-4793-a983-037a832ea9bb

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
- posted_at: `2026-11-09T23:44:49.6225070+00:00`

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
  "id": "a0ed6756-60e3-4793-a983-037a832ea9bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6225070+00:00"
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
  "subject_id": "7aa994c2-0a33-4bbc-adba-868a6d8e8111",
  "subject_name": "django/db/models/expressions::Case.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *cases, default=None, output_field=None, **extra)"
}
```
