# Fact 086abd09

Store id: e5e23f69-afb7-4b85-89fb-bb1c681c99c9

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:32:03.9426210+00:00`

## Data

```json
{
  "end_line": 393,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 392,
  "symbol": "Options.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":392,"selector":"L392-L393","symbol":"Options.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 393,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 392,
    "symbol": "Options.__str__"
  },
  "id": "e5e23f69-afb7-4b85-89fb-bb1c681c99c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9426210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 392,
        "selector": "L392-L393",
        "symbol": "Options.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "1b5c5a1a-105a-41ba-9032-6f61c128fd17",
  "subject_name": "django/db/models/options::Options.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
