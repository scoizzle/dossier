# Fact adb917cb

Store id: b979334b-9145-4b78-aafc-fa32e16e7f24

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
- posted_at: `2026-11-09T22:39:42.3739680+00:00`

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
  "id": "b979334b-9145-4b78-aafc-fa32e16e7f24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3739680+00:00"
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
  "subject_id": "b300ad3b-c87d-432d-91ca-61dac9e6e10c",
  "subject_name": "django/db/models/fields/__init__::CharField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, db_collation=None, **kwargs)"
}
```
