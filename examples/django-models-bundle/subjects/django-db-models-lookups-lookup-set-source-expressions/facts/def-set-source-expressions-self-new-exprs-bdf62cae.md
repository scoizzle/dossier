# Fact bdf62cae

Store id: cf569709-d11a-4f90-adab-ed766181d4f1

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
- posted_at: `2026-11-09T23:44:54.8574800+00:00`

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
  "id": "cf569709-d11a-4f90-adab-ed766181d4f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8574800+00:00"
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
  "subject_id": "fc5e3c18-c45b-4dbb-b50b-3cc7f1a0804f",
  "subject_name": "django/db/models/lookups::Lookup.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, new_exprs)"
}
```
