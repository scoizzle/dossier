# Fact c8a580cd

Store id: de3a8a54-3e65-434d-9f5a-6dace4b369bf

## Text

```text
def add_manager(self, manager)
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
- posted_at: `2026-11-09T23:32:03.9259500+00:00`

## Data

```json
{
  "end_line": 338,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 336,
  "symbol": "Options.add_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":336,"selector":"L336-L338","symbol":"Options.add_manager"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.add_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 338,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 336,
    "symbol": "Options.add_manager"
  },
  "id": "de3a8a54-3e65-434d-9f5a-6dace4b369bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9259500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 336,
        "selector": "L336-L338",
        "symbol": "Options.add_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "6563c053-3f31-40ed-afa9-a0acb4d4e216",
  "subject_name": "django/db/models/options::Options.add_manager",
  "tags": [
    "entity:method"
  ],
  "text": "def add_manager(self, manager)"
}
```
