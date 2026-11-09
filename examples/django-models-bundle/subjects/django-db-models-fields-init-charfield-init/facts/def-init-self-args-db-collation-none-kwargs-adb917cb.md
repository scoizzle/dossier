# Fact adb917cb

Store id: 6622db32-3e52-495b-981b-2ef2edb7ca4c

## Text

```text
def __init__(self, *args, db_collation=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.0589300+00:00`

## Data

```json
{
  "end_line": 1251,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1247,
  "symbol": "CharField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1247,"selector":"L1247-L1251","symbol":"CharField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1251,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1247,
    "symbol": "CharField.__init__"
  },
  "id": "6622db32-3e52-495b-981b-2ef2edb7ca4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0589300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1247,
        "selector": "L1247-L1251",
        "symbol": "CharField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4042b8c3-701e-4906-a2ad-7b5b893c9d81",
  "subject_name": "django/db/models/fields/__init__::CharField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, db_collation=None, **kwargs)"
}
```
