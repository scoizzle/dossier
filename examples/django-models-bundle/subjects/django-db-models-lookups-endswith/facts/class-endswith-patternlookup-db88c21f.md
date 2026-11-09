# Fact db88c21f

Store id: c418aaff-dcde-4834-adca-a780d71b7706

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
- posted_at: `2026-11-09T22:39:48.1900170+00:00`

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
  "id": "c418aaff-dcde-4834-adca-a780d71b7706",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1900170+00:00"
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
  "subject_id": "d0f7bb90-9c3a-42ec-a25b-bfd15ecfe4ea",
  "subject_name": "django/db/models/lookups::EndsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class EndsWith(PatternLookup)"
}
```
