# Fact ae8d1ab5

Store id: 49d30019-a885-44de-98c2-24fcaf514bdc

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.0326210+00:00`

## Data

```json
{
  "end_line": 174,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 172,
  "symbol": "Lookup.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L174","symbol":"Lookup.identity"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 174,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 172,
    "symbol": "Lookup.identity"
  },
  "id": "49d30019-a885-44de-98c2-24fcaf514bdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0326210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L174",
        "symbol": "Lookup.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f1334a41-0368-4c74-aaec-a2c2c2cdf684",
  "subject_name": "django/db/models/lookups::Lookup.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
