# Fact 892b5713

Store id: 302c2991-9d59-4c48-9532-beff093fd952

## Text

```text
def setup_pk(self, field)
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
- posted_at: `2026-11-09T23:32:03.9320960+00:00`

## Data

```json
{
  "end_line": 378,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 375,
  "symbol": "Options.setup_pk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":375,"selector":"L375-L378","symbol":"Options.setup_pk"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.setup_pk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 378,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 375,
    "symbol": "Options.setup_pk"
  },
  "id": "302c2991-9d59-4c48-9532-beff093fd952",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9320960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 375,
        "selector": "L375-L378",
        "symbol": "Options.setup_pk"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "eb14266d-d576-4c2d-8e57-da42fc29803a",
  "subject_name": "django/db/models/options::Options.setup_pk",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_pk(self, field)"
}
```
