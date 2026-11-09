# Fact bfccb6c9

Store id: ca4a5f73-5230-4365-9eae-bebdf0074379

## Text

```text
class IContains(Contains)
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
- posted_at: `2026-11-09T23:32:03.3605520+00:00`

## Data

```json
{
  "end_line": 632,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 630,
  "symbol": "IContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":630,"selector":"L630-L632","symbol":"IContains"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 632,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 630,
    "symbol": "IContains"
  },
  "id": "ca4a5f73-5230-4365-9eae-bebdf0074379",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3605520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 630,
        "selector": "L630-L632",
        "symbol": "IContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4b35ee6b-0cc3-476a-8c41-c6dfb85e8fb7",
  "subject_name": "django/db/models/lookups::IContains",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IContains(Contains)"
}
```
