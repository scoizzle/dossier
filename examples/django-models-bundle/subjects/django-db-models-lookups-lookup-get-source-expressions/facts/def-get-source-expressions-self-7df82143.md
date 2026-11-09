# Fact 7df82143

Store id: 5132a53e-c68a-45d0-bc21-4b24eb28d24f

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:32:03.1336600+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 78,
  "symbol": "Lookup.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L81","symbol":"Lookup.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 78,
    "symbol": "Lookup.get_source_expressions"
  },
  "id": "5132a53e-c68a-45d0-bc21-4b24eb28d24f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1336600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L81",
        "symbol": "Lookup.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4b80e3f9-5cb8-432b-8a08-240b8fbe1f70",
  "subject_name": "django/db/models/lookups::Lookup.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
