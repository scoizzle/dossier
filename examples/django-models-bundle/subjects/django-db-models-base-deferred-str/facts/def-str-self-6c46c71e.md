# Fact 6c46c71e

Store id: 12134df3-efb5-4627-ba4c-c4e0a478ba4f

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
- posted_at: `2026-11-09T23:44:48.5164760+00:00`

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
  "id": "12134df3-efb5-4627-ba4c-c4e0a478ba4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5164760+00:00"
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
  "subject_id": "cf524c1a-c893-4c1b-82d7-61cc17771bd3",
  "subject_name": "django/db/models/base::Deferred.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
