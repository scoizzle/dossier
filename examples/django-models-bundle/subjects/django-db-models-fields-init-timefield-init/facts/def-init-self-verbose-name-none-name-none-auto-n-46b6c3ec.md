# Fact 46b6c3ec

Store id: e65e4c43-6233-4660-b7e3-738538ce120f

## Text

```text
def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )
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
- posted_at: `2026-11-09T23:44:50.2521000+00:00`

## Data

```json
{
  "end_line": 2622,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2615,
  "symbol": "TimeField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2615,"selector":"L2615-L2622","symbol":"TimeField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2622,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2615,
    "symbol": "TimeField.__init__"
  },
  "id": "e65e4c43-6233-4660-b7e3-738538ce120f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2521000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2615,
        "selector": "L2615-L2622",
        "symbol": "TimeField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b32a69d4-817b-4f28-b390-62279690e968",
  "subject_name": "django/db/models/fields/__init__::TimeField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
