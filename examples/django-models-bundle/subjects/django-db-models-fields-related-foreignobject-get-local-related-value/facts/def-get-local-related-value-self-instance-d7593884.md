# Fact d7593884

Store id: c61683a1-28fb-488d-ac35-52cfe26b78b7

## Text

```text
def get_local_related_value(self, instance)
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
- posted_at: `2026-11-09T23:31:58.6926980+00:00`

## Data

```json
{
  "end_line": 825,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 824,
  "symbol": "ForeignObject.get_local_related_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":824,"selector":"L824-L825","symbol":"ForeignObject.get_local_related_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_local_related_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 825,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 824,
    "symbol": "ForeignObject.get_local_related_value"
  },
  "id": "c61683a1-28fb-488d-ac35-52cfe26b78b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6926980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 824,
        "selector": "L824-L825",
        "symbol": "ForeignObject.get_local_related_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9830c821-3b8d-4637-a275-97a70bf73104",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_local_related_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_local_related_value(self, instance)"
}
```
