# Fact bdf62cae

Store id: e8a954a2-4dbe-4f8d-9edf-ed5720a65275

## Text

```text
def set_source_expressions(self, new_exprs)
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
- posted_at: `2026-11-09T23:32:03.1372020+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 83,
  "symbol": "Lookup.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L87","symbol":"Lookup.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 83,
    "symbol": "Lookup.set_source_expressions"
  },
  "id": "e8a954a2-4dbe-4f8d-9edf-ed5720a65275",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1372020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L87",
        "symbol": "Lookup.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f21811af-7387-4852-84a1-14df0f8b06f2",
  "subject_name": "django/db/models/lookups::Lookup.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, new_exprs)"
}
```
