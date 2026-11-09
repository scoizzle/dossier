# Fact 619827e6

Store id: aa09609b-d526-4d45-af5d-349e1db785d8

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
- posted_at: `2026-11-09T23:32:02.8995010+00:00`

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
  "id": "aa09609b-d526-4d45-af5d-349e1db785d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.8995010+00:00"
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
  "subject_id": "854aa49b-6673-422a-98ba-65f163f50fbe",
  "subject_name": "django/db/models/indexes::Index.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, fields=(), name=None, db_tablespace=None, opclasses=(), condition=None, include=None, )"
}
```
