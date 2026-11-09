# Fact a1839bba

Store id: 36c9af41-41d3-452d-81fd-9e93efce55ad

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.4640510+00:00`

## Data

```json
{
  "end_line": 133,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 125,
  "symbol": "RelatedField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":125,"selector":"L125-L133","symbol":"RelatedField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 133,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 125,
    "symbol": "RelatedField.check"
  },
  "id": "36c9af41-41d3-452d-81fd-9e93efce55ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4640510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 125,
        "selector": "L125-L133",
        "symbol": "RelatedField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c7d33690-d8e4-4326-b866-53dc4aeca347",
  "subject_name": "django/db/models/fields/related::RelatedField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
