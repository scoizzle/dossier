# Fact 1fb8f859

Store id: 7a7b121c-0ff4-49a6-8587-3b9276894048

## Text

```text
def get_lookup(self, lookup_name)
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
- posted_at: `2026-11-09T23:44:52.4563420+00:00`

## Data

```json
{
  "end_line": 116,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 115,
  "symbol": "ForeignObjectRel.get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":115,"selector":"L115-L116","symbol":"ForeignObjectRel.get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 116,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 115,
    "symbol": "ForeignObjectRel.get_lookup"
  },
  "id": "7a7b121c-0ff4-49a6-8587-3b9276894048",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4563420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 115,
        "selector": "L115-L116",
        "symbol": "ForeignObjectRel.get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "ea4d8068-88cf-45ef-ac8b-fd8beac9711d",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup_name)"
}
```
