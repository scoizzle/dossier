# Fact 3cf09c4f

Store id: 74f8b3ec-2cb0-4798-a53e-39ef41773338

## Text

```text
contains function get_blank_choice_label
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.9512730+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/utils::get_blank_choice_label](../../django-db-models-utils-get-blank-choice-label/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"symbol":"get_blank_choice_label"}`

## Referenced by

None.

## Subject

[django/db/models/utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "74f8b3ec-2cb0-4798-a53e-39ef41773338",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9512730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 74,
        "symbol": "get_blank_choice_label"
      },
      "rel": "contains",
      "target": "eb54e3f6-7df3-4b9b-a5aa-d65a0329e347"
    }
  ],
  "status": "live",
  "subject_id": "8d25c560-4eac-44c9-a77d-da20cef77164",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_blank_choice_label"
}
```
