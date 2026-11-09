# Fact 30fc87f5

Store id: 4c1722d3-7b15-41cf-81a5-3ef6907823c0

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
- posted_at: `2026-11-09T23:32:03.4060210+00:00`

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
  "id": "4c1722d3-7b15-41cf-81a5-3ef6907823c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4060210+00:00"
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
  "subject_id": "aa571be8-3e60-4a2f-8543-a27928cf6e78",
  "subject_name": "django/db/models/lookups::IRegex",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IRegex(Regex)"
}
```
