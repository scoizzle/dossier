# Fact d8004457

Store id: 2b4bdca0-acbf-442d-8584-3675504629bf

## Text

```text
def save_form_data(self, instance, data)
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
- posted_at: `2026-11-09T23:44:51.6746250+00:00`

## Data

```json
{
  "end_line": 2186,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2185,
  "symbol": "ManyToManyField.save_form_data"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2185,"selector":"L2185-L2186","symbol":"ManyToManyField.save_form_data"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.save_form_data](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2186,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2185,
    "symbol": "ManyToManyField.save_form_data"
  },
  "id": "2b4bdca0-acbf-442d-8584-3675504629bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6746250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2185,
        "selector": "L2185-L2186",
        "symbol": "ManyToManyField.save_form_data"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "37b2da61-cc98-44ee-8caa-c32c2b100980",
  "subject_name": "django/db/models/fields/related::ManyToManyField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```
