# Fact 6c46c71e

Store id: b291bb46-eb98-4f58-b412-3435bc9c5e21

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
- posted_at: `2026-11-09T23:31:53.7199390+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "method",
  "parent": "Deferred",
  "start_line": 65,
  "symbol": "Deferred.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":65,"selector":"L65-L66","symbol":"Deferred.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "method",
    "parent": "Deferred",
    "start_line": 65,
    "symbol": "Deferred.__str__"
  },
  "id": "b291bb46-eb98-4f58-b412-3435bc9c5e21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7199390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 65,
        "selector": "L65-L66",
        "symbol": "Deferred.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "c69a5b6b-2311-496f-8463-85821c4f708a",
  "subject_name": "django/db/models/base::Deferred.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
