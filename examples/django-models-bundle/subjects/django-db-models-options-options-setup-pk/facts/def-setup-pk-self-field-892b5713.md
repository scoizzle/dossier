# Fact 892b5713

Store id: 5872055e-4dc0-4d83-808f-7cf98dfcd719

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
- posted_at: `2026-11-09T23:44:55.4929940+00:00`

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
  "id": "5872055e-4dc0-4d83-808f-7cf98dfcd719",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4929940+00:00"
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
  "subject_id": "52574cba-496d-46c5-b41d-4a201da6f328",
  "subject_name": "django/db/models/options::Options.setup_pk",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_pk(self, field)"
}
```
