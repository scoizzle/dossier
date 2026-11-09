# Fact 578daeb0

Store id: e3030bcd-989b-4014-87b7-4658b87ad84a

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
- posted_at: `2026-11-09T23:44:55.5940890+00:00`

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
  "id": "e3030bcd-989b-4014-87b7-4658b87ad84a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5940890+00:00"
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
  "subject_id": "88c6c83c-1fb5-4e85-b0df-f1354c5804cf",
  "subject_name": "django/db/models/options::Options.is_composite_pk",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_composite_pk(self)"
}
```
