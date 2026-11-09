# Fact 619827e6

Store id: c77133b9-a42c-4044-ac62-96d32803b13c

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
- posted_at: `2026-11-09T23:44:54.6657920+00:00`

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
  "id": "c77133b9-a42c-4044-ac62-96d32803b13c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6657920+00:00"
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
  "subject_id": "1c39f540-475b-4007-9538-d51ad3701722",
  "subject_name": "django/db/models/indexes::Index.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, fields=(), name=None, db_tablespace=None, opclasses=(), condition=None, include=None, )"
}
```
