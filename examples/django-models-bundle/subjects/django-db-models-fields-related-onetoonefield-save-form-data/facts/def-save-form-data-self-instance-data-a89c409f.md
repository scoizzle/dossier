# Fact a89c409f

Store id: 0680d388-71de-4be4-812c-5e68ed0bc685

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
- posted_at: `2026-11-09T23:31:58.8134230+00:00`

## Data

```json
{
  "end_line": 1394,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1386,
  "symbol": "OneToOneField.save_form_data"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1386,"selector":"L1386-L1394","symbol":"OneToOneField.save_form_data"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.save_form_data](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1394,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1386,
    "symbol": "OneToOneField.save_form_data"
  },
  "id": "0680d388-71de-4be4-812c-5e68ed0bc685",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8134230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1386,
        "selector": "L1386-L1394",
        "symbol": "OneToOneField.save_form_data"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "f2740ae3-d94a-4c76-a9cb-bbe6b7743359",
  "subject_name": "django/db/models/fields/related::OneToOneField.save_form_data",
  "tags": [
    "entity:method"
  ],
  "text": "def save_form_data(self, instance, data)"
}
```
