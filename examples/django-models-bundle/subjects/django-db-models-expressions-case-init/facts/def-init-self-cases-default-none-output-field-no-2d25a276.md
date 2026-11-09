# Fact 2d25a276

Store id: 20bde317-4ede-4bbf-8853-70348e0c13a1

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
- posted_at: `2026-11-09T22:39:41.7052140+00:00`

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
  "id": "20bde317-4ede-4bbf-8853-70348e0c13a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7052140+00:00"
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
  "subject_id": "554238a0-f905-464e-9e52-a02c69780257",
  "subject_name": "django/db/models/expressions::Case.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *cases, default=None, output_field=None, **extra)"
}
```
