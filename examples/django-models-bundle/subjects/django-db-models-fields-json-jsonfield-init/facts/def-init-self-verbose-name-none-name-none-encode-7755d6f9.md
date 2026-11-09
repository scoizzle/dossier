# Fact 7755d6f9

Store id: ed27dd8f-e3ef-43bc-8e86-f0877eaee27d

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
- posted_at: `2026-11-09T22:39:43.5991470+00:00`

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
  "id": "ed27dd8f-e3ef-43bc-8e86-f0877eaee27d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.5991470+00:00"
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
  "subject_id": "e3b86261-f038-4ce0-b26a-c771b8ce8ee4",
  "subject_name": "django/db/models/fields/json::JSONField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, encoder=None, decoder=None, **kwargs, )"
}
```
