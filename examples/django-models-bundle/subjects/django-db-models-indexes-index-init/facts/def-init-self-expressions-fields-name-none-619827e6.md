# Fact 619827e6

Store id: 37ee5b52-5eba-4f3d-850b-fcb9286d2db6

## Text

```text
def __init__( self, *expressions, fields=(), name=None, db_tablespace=None, opclasses=(), condition=None, include=None, )
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
- posted_at: `2026-11-09T22:39:47.7657330+00:00`

## Data

```json
{
  "end_line": 80,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 20,
  "symbol": "Index.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":20,"selector":"L20-L80","symbol":"Index.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 80,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 20,
    "symbol": "Index.__init__"
  },
  "id": "37ee5b52-5eba-4f3d-850b-fcb9286d2db6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.7657330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 20,
        "selector": "L20-L80",
        "symbol": "Index.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "3765dba2-896b-4511-8247-8a8689dd0b98",
  "subject_name": "django/db/models/indexes::Index.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, fields=(), name=None, db_tablespace=None, opclasses=(), condition=None, include=None, )"
}
```
