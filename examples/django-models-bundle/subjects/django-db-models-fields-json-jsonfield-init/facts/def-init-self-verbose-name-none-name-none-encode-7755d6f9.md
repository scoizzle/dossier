# Fact 7755d6f9

Store id: 18934e42-abf8-4e3d-8423-fb49a851a177

## Text

```text
def __init__( self, verbose_name=None, name=None, encoder=None, decoder=None, **kwargs, )
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
- posted_at: `2026-11-09T23:44:50.9326270+00:00`

## Data

```json
{
  "end_line": 46,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 32,
  "symbol": "JSONField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":32,"selector":"L32-L46","symbol":"JSONField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 46,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 32,
    "symbol": "JSONField.__init__"
  },
  "id": "18934e42-abf8-4e3d-8423-fb49a851a177",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9326270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 32,
        "selector": "L32-L46",
        "symbol": "JSONField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7dd4821a-956b-4195-be95-3096f5f3381b",
  "subject_name": "django/db/models/fields/json::JSONField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, encoder=None, decoder=None, **kwargs, )"
}
```
