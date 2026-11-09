# Fact db88c21f

Store id: 8e7cc6f2-49b9-4a4b-baf3-6ee0cce58ba5

## Text

```text
class EndsWith(PatternLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3711000+00:00`

## Data

```json
{
  "end_line": 649,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 646,
  "symbol": "EndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":646,"selector":"L646-L649","symbol":"EndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::EndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 649,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 646,
    "symbol": "EndsWith"
  },
  "id": "8e7cc6f2-49b9-4a4b-baf3-6ee0cce58ba5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3711000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 646,
        "selector": "L646-L649",
        "symbol": "EndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "9cae3b83-3ae4-4a4a-98f4-67b59bca28f5",
  "subject_name": "django/db/models/lookups::EndsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class EndsWith(PatternLookup)"
}
```
