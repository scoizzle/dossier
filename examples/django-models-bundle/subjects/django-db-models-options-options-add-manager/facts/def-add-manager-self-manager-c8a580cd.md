# Fact c8a580cd

Store id: 89703df8-6fc7-4e60-a4f4-dac65d3279f3

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
- posted_at: `2026-11-09T23:44:55.4879780+00:00`

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
  "id": "89703df8-6fc7-4e60-a4f4-dac65d3279f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4879780+00:00"
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
  "subject_id": "01c6fa4b-4274-4f9a-92d5-efcf4cddb7c3",
  "subject_name": "django/db/models/options::Options.add_manager",
  "tags": [
    "entity:method"
  ],
  "text": "def add_manager(self, manager)"
}
```
