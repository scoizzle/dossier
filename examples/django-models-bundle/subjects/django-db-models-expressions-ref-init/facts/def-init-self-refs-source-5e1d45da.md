# Fact 5e1d45da

Store id: f43abc63-2991-45f8-a547-a05d931c4abb

## Text

```text
def __init__(self, refs, source)
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
- posted_at: `2026-11-09T23:44:49.5727100+00:00`

## Data

```json
{
  "end_line": 1455,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1453,
  "symbol": "Ref.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1453,"selector":"L1453-L1455","symbol":"Ref.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1455,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1453,
    "symbol": "Ref.__init__"
  },
  "id": "f43abc63-2991-45f8-a547-a05d931c4abb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5727100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1453,
        "selector": "L1453-L1455",
        "symbol": "Ref.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2208cc00-fb39-4e96-9107-245becbd15b9",
  "subject_name": "django/db/models/expressions::Ref.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, refs, source)"
}
```
