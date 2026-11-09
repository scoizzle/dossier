# Fact 30fc87f5

Store id: d7465c3e-eb55-4ef2-a1cd-d711b5c64e36

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
- posted_at: `2026-11-09T23:44:55.0512230+00:00`

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
  "id": "d7465c3e-eb55-4ef2-a1cd-d711b5c64e36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0512230+00:00"
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
  "subject_id": "6fb5298c-28d8-4cd1-b441-60ef2f3e02b9",
  "subject_name": "django/db/models/lookups::IRegex",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IRegex(Regex)"
}
```
