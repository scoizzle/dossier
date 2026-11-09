# Fact 9b0dee21

Store id: 1e578016-b9fe-4b5f-b7ef-e7d986806d3a

## Text

```text
def get_path_info(self, filtered_relation=None)
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
- posted_at: `2026-11-09T23:44:52.4958030+00:00`

## Data

```json
{
  "end_line": 236,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 232,
  "symbol": "ForeignObjectRel.get_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":232,"selector":"L232-L236","symbol":"ForeignObjectRel.get_path_info"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 236,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 232,
    "symbol": "ForeignObjectRel.get_path_info"
  },
  "id": "1e578016-b9fe-4b5f-b7ef-e7d986806d3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4958030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 232,
        "selector": "L232-L236",
        "symbol": "ForeignObjectRel.get_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "29be45b8-1a3a-4337-b7f0-c1c0b36383d1",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
