# Fact 30fc87f5

Store id: 8e4a8e17-615c-4d5f-ae5d-9bd5078ce5ea

## Text

```text
class IRegex(Regex)
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
- posted_at: `2026-11-09T22:39:48.2130590+00:00`

## Data

```json
{
  "end_line": 709,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 707,
  "symbol": "IRegex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":707,"selector":"L707-L709","symbol":"IRegex"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IRegex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 709,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 707,
    "symbol": "IRegex"
  },
  "id": "8e4a8e17-615c-4d5f-ae5d-9bd5078ce5ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2130590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 707,
        "selector": "L707-L709",
        "symbol": "IRegex"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4122d1ae-1091-4f91-bb78-b5cec30b7e14",
  "subject_name": "django/db/models/lookups::IRegex",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IRegex(Regex)"
}
```
