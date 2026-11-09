# Fact d8004457

Store id: bdc19fa0-39d2-452a-9c84-baa7a3a74753

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
- posted_at: `2026-11-09T23:31:58.8974870+00:00`

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
  "id": "bdc19fa0-39d2-452a-9c84-baa7a3a74753",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8974870+00:00"
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
  "subject_id": "f1370e96-9430-496c-b25e-20711db5b817",
  "subject_name": "django/db/models/fields/related::ManyToManyField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```
