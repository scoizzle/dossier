# Fact b414c849

Store id: fd36e064-12ab-4b29-9a5b-635a751beac6

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:31:53.7340390+00:00`

## Data

```json
{
  "end_line": 651,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 648,
  "symbol": "Model.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":648,"selector":"L648-L651","symbol":"Model.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 651,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 648,
    "symbol": "Model.__hash__"
  },
  "id": "fd36e064-12ab-4b29-9a5b-635a751beac6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7340390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 648,
        "selector": "L648-L651",
        "symbol": "Model.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "798d61fa-0de8-484e-a4a4-fdcc7c755cde",
  "subject_name": "django/db/models/base::Model.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
