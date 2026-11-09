# Fact 578daeb0

Store id: 39d842eb-d5f9-469d-804c-1bdbcd6626ba

## Text

```text
def is_composite_pk(self)
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
- posted_at: `2026-11-09T22:39:48.9692400+00:00`

## Data

```json
{
  "end_line": 998,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 996,
  "symbol": "Options.is_composite_pk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":996,"selector":"L996-L998","symbol":"Options.is_composite_pk"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.is_composite_pk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 998,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 996,
    "symbol": "Options.is_composite_pk"
  },
  "id": "39d842eb-d5f9-469d-804c-1bdbcd6626ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9692400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 996,
        "selector": "L996-L998",
        "symbol": "Options.is_composite_pk"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "1cbf1135-6d35-4bec-ad79-7b22c0afb312",
  "subject_name": "django/db/models/options::Options.is_composite_pk",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_composite_pk(self)"
}
```
