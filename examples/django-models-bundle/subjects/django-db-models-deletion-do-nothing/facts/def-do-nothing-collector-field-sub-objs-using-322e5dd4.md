# Fact 322e5dd4

Store id: ddb9ff39-2469-48a8-9fc9-281735276467

## Text

```text
def DO_NOTHING(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.0256660+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 80,
  "symbol": "DO_NOTHING"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"selector":"L80-L81","symbol":"DO_NOTHING"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DO_NOTHING](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 80,
    "symbol": "DO_NOTHING"
  },
  "id": "ddb9ff39-2469-48a8-9fc9-281735276467",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0256660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 80,
        "selector": "L80-L81",
        "symbol": "DO_NOTHING"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "0069c23d-287a-4a08-b84e-3a05742eb4fb",
  "subject_name": "django/db/models/deletion::DO_NOTHING",
  "tags": [
    "entity:function"
  ],
  "text": "def DO_NOTHING(collector, field, sub_objs, using)"
}
```
